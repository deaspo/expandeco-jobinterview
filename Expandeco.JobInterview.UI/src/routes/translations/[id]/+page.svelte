<script>
    import {onMount} from "svelte";
    import axios from "axios";
    import UserStore from "$lib/stores/userStore.js";
    import userStore from "$lib/stores/userStore.js";
    import {goto} from "$app/navigation";

    export let data;
    let translation;
    let loggedUser = $userStore;

    onMount(() => {
        axios.get(`translations/${data.id}`).then(res => {
            translation = res.data;
        }).catch((err) => console.log(err));
    })

    const navigateToTranslationPage = () => goto("/translations");
    const handleEditTranslationBtnClick = () => goto(`/translations/update/${data.id}`);
    /*
    * Only translator can view the translated text
    * Only the manager can view the assigned translator
     */
</script>

<div class="card">
    <div class="card-body row">
        {#if translation}
            <div class="mb-3">
                <h1>{translation.title}</h1>
            </div>
            <div class="mb-3">
                <p class="lead">{translation.text}</p>
            </div>
            {#if (loggedUser.user.typeId === 2)}
                <div class="mb-3">
                    <span class="badge bg-info">Translated text</span>
                    <span class="">{translation.translatedText? translation.translatedText: ''}</span>
                </div>
            {/if}
            <div class="mb-3">
                <span class="badge bg-info">Created by</span>
                <span class="">{translation.createdBy.name}</span>
            </div>
            {#if (loggedUser.user.typeId === 1)}
                <div class="mb-3">
                    <span class="badge bg-info">Assigned To</span>
                    <span class="">{translation.assignedTo ? translation.assignedTo.name ? translation.assignedTo.name : '' : ''}</span>
                </div>
            {/if}
            <div class="row justify-content-between">
                <div class="col-auto">
                    <button type="button" class="btn btn-primary" on:click={handleEditTranslationBtnClick}>Edit</button>
                </div>
                <div class="col-auto">
                    <button type="button" class="btn btn-secondary" on:click={navigateToTranslationPage}>Go Back</button>
                </div>
            </div>
        {:else }
            <h1>No translation found</h1>
        {/if}
    </div>
</div>
