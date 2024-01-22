import axios from "axios";
import {goto} from "$app/navigation";

export const actions = {
  default: async ({request}) => {
      const data = await request.formData();

      axios.post(`translations/create`, {
          title: data.get('title'),
          text: data.get('text'),
          sourceLanguageId: data.get('sourceLanguageId'),
          targetLanguageId: data.get('targetLanguageId')
      }).then(res => {
          goto(`/translations/{${res.data.id}`, {
              replaceState: true
          });
      }).catch((err) => console.log(err));
  }
}