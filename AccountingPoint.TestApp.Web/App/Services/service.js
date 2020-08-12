import Axios from 'axios';

const RESOURCE_NAME = '/api/data';
/**Сервис для запроса к backend */
export default {
    getAll(buttonId, delay) {
  
        console.log("Ожидание: " + delay + " секунды");
        return Axios.get(RESOURCE_NAME, {
            params: {
                ButtonId: buttonId,
                SecondsDelay: delay
            }
        });
    }
};