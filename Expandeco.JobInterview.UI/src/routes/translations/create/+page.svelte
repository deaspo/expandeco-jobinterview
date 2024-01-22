<script>
    import {goto} from "$app/navigation";
    import enums from "$lib/enums.js";
    import languageStore from "$lib/stores/languageStore.js";
    import axios from "axios";
    let supportedLanguages = $languageStore;

    const navigateToTranslationPage = () => goto("/translations");

    const handleFormSubmission = (e) => {
        const formData = new FormData(e.target);

        let fieldsData = {};
        for (let field of formData) {
            const [key, value] = field;
            fieldsData[key] = value;
        }
        axios.post(`translations/create`, {...fieldsData}).then(res => {
            goto(`/translations/${res.data.id}`, {
                replaceState: true
            });
        }).catch((err) => console.log(err));
    }
</script>

<div class="row card">
    <form class="card-body" on:submit|preventDefault={handleFormSubmission}>
        <div class="mb-3">
            <label for="title" class="form-label">Title</label>
            <input name="title" type="text" class="form-control" id="title" aria-describedby="title" required>
        </div>
        <div class="mb-3 form-floating">
            <textarea name="text" required class="form-control" placeholder="Text" id="floatingTextarea2" style="height: 100px"></textarea>
            <label for="floatingTextarea2">Text</label>
        </div>
        <div class="mb-3 form-floating">
            <select name="sourceLanguageId" required class="form-select" id="sourceLanguage" aria-label="Source language">
                {#each supportedLanguages as language}
                    <option value="{language.id}">{language.value}</option>
                {/each}
            </select>
            <label for="sourceLanguage">Source language</label>
        </div>
        <div class="mb-3 form-floating">
            <select name="targetLanguageId" required class="form-select" id="targetLanguage" aria-label="Target language">
                {#each supportedLanguages as language}
                    <option value="{language.id}">{language.value}</option>
                {/each}
            </select>
            <label for="sourceLanguage">Target language</label>
        </div>
        <div class="mb-3">
            <label for="deadline" class="form-label">Deadline</label>
            <input name="deadline" type="datetime-local" class="form-control" id="deadline" aria-describedby="deadline">
        </div>
        <div class="row g-2 justify-content-between">
            <div class="col-auto">
                <button type="submit" class="btn btn-primary">Submit</button>
            </div>
            <div class="col-auto">
                <button on:click={navigateToTranslationPage} type="button" class="btn btn-secondary">Cancel</button>
            </div>
        </div>
    </form>
</div>