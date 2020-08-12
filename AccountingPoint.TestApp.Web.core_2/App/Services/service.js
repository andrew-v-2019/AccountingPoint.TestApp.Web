import Axios from 'axios';

const api = '/api/data';

export default {
    getAll(buttonId, delay) {
        return Axios.get(api, {
            params: {
                ButtonId: buttonId,
                SecondsDelay: delay
            }
        });
    }
};