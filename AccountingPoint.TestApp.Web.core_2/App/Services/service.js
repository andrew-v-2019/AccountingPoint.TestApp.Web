import Axios from 'axios';

const api = '/api/data';
/**Сервис для запроса к backend */
export default {
    /**
     *@description Проверка: является ли кнопка текущей нажатой
     *@param {Number} buttonId Идентификатор кнопки
     *@param {Number} delay Сколько ждать в секундах
     */
    getAll(buttonId, delay) {
        console.log("Ожидание: " + delay + " секунды");
        return Axios.get(api, {
            params: {
                ButtonId: buttonId,
                SecondsDelay: delay
            }
        });
    }
};