import axios from "axios";
export const prerender = true;

export async function load({params}) {
    let users;
    let selectedUser;
    axios.defaults.baseURL = "https://localhost:5001";
    try {
        const res = await axios.get('users');
        if (res) users = res.data;
        if (users.length) selectedUser = users[0].id;
    } catch (err) {
        console.log(err)
    }
    return {
        users,
        selectedUser
    }
}
