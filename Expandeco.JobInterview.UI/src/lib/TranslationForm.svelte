<script>
    import userStore from "$lib/stores/userStore.js";
    import languageStore from "$lib/stores/languageStore.js";
    import {onMount} from "svelte";
    import enums from "$lib/enums.js";
    import axios from "axios";

    let supportedLanguages = $languageStore;

    let credentials = $userStore;
    export let data;
    export let handleFormSubmission;
    let clientCanEdit = false;
    let managerCanEdit = false;
    let translatorCanEdit = false;

    let translators = [];
    export let navigateWhenUserCancelsAction;

    onMount(async () => {
        if (credentials) {
            if (credentials.user.typeId === enums.userTypes.client) clientCanEdit = true;
            if (credentials.user.typeId === enums.userTypes.translationManager) managerCanEdit = true;
            if (credentials.user.typeId === enums.userTypes.translator) translatorCanEdit = true;
        }
        try {
            const res = await axios.get('users');
            if (res) translators = res.data.filter(user => user.typeId === enums.userTypes.translator);
        } catch (err) {
            console.log(err)
        }
    })
</script>

<div class="row card">
    <form class="card-body" on:submit|preventDefault={handleFormSubmission}>
        <div class="mb-3">
            <label for="title" class="form-label">Title</label>
            <input readonly="{!clientCanEdit}" value="{data.title}" name="title" type="text" class="form-control" id="title" aria-describedby="title" required>
        </div>
        <div class="mb-3 form-floating">
            <textarea readonly="{!clientCanEdit}" name="text" required class="form-control" placeholder="Text" id="floatingTextarea2" style="height: 100px">{data.text}</textarea>
            <label for="floatingTextarea2">Text</label>
        </div>
        {#if translatorCanEdit}
            <div class="mb-3 form-floating">
                <textarea name="translatedText" class="form-control" placeholder="Text" id="floatingTextarea2" style="height: 100px">
                    {data.translatedText? data.translatedText: ''}
                </textarea>
                <label for="translatedText">Translated text</label>
            </div>
        {/if}
        <div class="mb-3 form-floating">
            <select name="sourceLanguageId" required class="form-select" id="sourceLanguage" aria-label="Source language">
                {#each supportedLanguages as language}
                    <option disabled={!clientCanEdit && data.sourceLanguage.id !== language.id} selected={data.sourceLanguage.id === language.id} value="{language.id}">{language.value}</option>
                {/each}
            </select>
            <label for="sourceLanguage">Source language</label>
        </div>
        <div class="mb-3 form-floating">
            <select name="targetLanguageId" required class="form-select" id="targetLanguage" aria-label="Target language">
                {#each supportedLanguages as language}
                    <option disabled={!clientCanEdit && data.targetLanguage.id !== language.id} selected={data.targetLanguage.id === language.id} value="{language.id}">{language.value}</option>
                {/each}
            </select>
            <label for="sourceLanguage">Target language</label>
        </div>
        {#if managerCanEdit}
            <div class="mb-3 form-floating">
                <select name="assignedToId" required class="form-select" id="assignedToId" aria-label="Assigned translator">
                    {#each translators as translator (translator.id)}
                        <option selected={data.assignedTo && data.assignedTo.id === translator.id} value="{translator.id}">{translator.name}</option>
                    {/each}
                </select>
                <label for="sourceLanguage">Assigned translator</label>
            </div>
        {/if}
        <div class="row g-2 justify-content-between">
            <div class="col-auto">
                <button type="submit" class="btn btn-primary">Submit</button>
            </div>
            <div class="col-auto">
                <button on:click={navigateWhenUserCancelsAction} type="button" class="btn btn-secondary">Cancel</button>
            </div>
        </div>
    </form>
</div>