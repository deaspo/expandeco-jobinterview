<script>
	import { goto } from "$app/navigation";
	import axios from "axios";
	import userStore from "$lib/stores/userStore.js";
	import { onMount } from "svelte";

	let users = [];
	export let data;
	onMount(() => {
		users = data.users;
	});

	const handleLogin = () => {
		const user = users.find((x) => x.id === data.selectedUser);
		if (user) {
			axios.post("users/login?id=" + user.id).then((result) => {
				userStore.set({
					user,
					token: result.data,
				});
				goto("translations");
			});
		}
	};
</script>

<section>
	<div class="row justify-content-center">
		<div class="col-md-3">
			<div class="mb-3">
				<select class="form-select" bind:value={data.selectedUser}>
					{#each users || [] as item}
						<option value={item.id}
							>{item.name} ({item.type.title})</option
						>
					{/each}
				</select>
			</div>
			<button class="btn btn-primary w-100" on:click={handleLogin}
				>Prihlásiť sa</button
			>
		</div>
	</div>
</section>
