import Axios from 'axios';

const RESOURCE_NAME = '/api/data';

export default {
    getAll(buttonId, delay) {
        return Axios.get(RESOURCE_NAME, {
            params: {
                ButtonId: buttonId,
                SecondsDelay: delay
            }
        });
    }
};