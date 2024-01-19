import axios from "axios";
export const prerender = true;

export function load({params}) {
    let users;
    let selectedUser;
    axios.get('users').then(result => {
        users = result.data;
        if (users.length) selectedUser = users[0].id;
    }).catch((err) => console.log(err));;

    return {
        users,
        selectedUser
    }
}
