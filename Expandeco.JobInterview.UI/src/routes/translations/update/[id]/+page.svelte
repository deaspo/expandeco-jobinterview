<script>
    import {goto} from "$app/navigation";
    import {onMount} from "svelte";
    import axios from "axios";
    import userStore from "$lib/stores/userStore.js";
    import TranslationForm from "$lib/TranslationForm.svelte";

    export let data;
    let translation;
    const navigateToTranslationDetailsPage = () => goto(`/translations/${data.id}`);
    const handleFormSubmission = (e) => {
        const formData = new FormData(e.target);
        let fieldsData = {
            translationId: data.id,
        };
        for (let field of formData) {
            const [key, value] = field;
            fieldsData[key] = value;
        }
        axios.patch(`/translations/update`, {...fieldsData}).then(res => {
            goto(`/translations/${res.data.id}`, {
                replaceState: true
            });
        }).catch((err) => console.log(err));
    }
    onMount(() => {
        axios.get(`translations/${data.id}`).then(res => {
            translation = res.data;
        }).catch((err) => console.log(err));
    })
    /*
    * Only assigned translator can edit translation text
    * Only manager can change assigned translator
    * only client can edit titel, text, source and target language
    * */
</script>

<section>
    {#if translation}
        <TranslationForm
                data={translation}
                navigateWhenUserCancelsAction={navigateToTranslationDetailsPage}
                handleFormSubmission={handleFormSubmission}
        />
    {/if}
</section>