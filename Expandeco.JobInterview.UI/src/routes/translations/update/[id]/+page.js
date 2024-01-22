import axios from "axios";
import enums from "$lib/enums.js";

export async function load({params}) {
    return {
        id: params.id,
    }
}