import {readable} from "svelte/store";
export default readable(
    [
        {
            id: 1,
            value: "Angličtina"
        },
        {
            id: 2,
            value: "Slovenčina"
        },
        {
            id: 3,
            value: "Čeština"
        },
        {
            id: 4,
            value: "Nemčina"
        }
    ]
)