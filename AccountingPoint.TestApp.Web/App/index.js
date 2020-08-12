import Vue from 'vue';
import App from './App.vue';
import MainPage from './Components/mainPage.vue';
import PageWithButtons from './Components/PageWithButtons.vue';

Vue.config.productionTip = false;

Vue.component('main-page', MainPage);
Vue.component('page-with-buttons', PageWithButtons);


new Vue({
    el: '#app',
    template: '<App/>',
    components:
    {
         App
    }
});