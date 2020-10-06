import Vue from 'vue'
import App from './App.vue'
import axios from 'axios'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify.min.css'
import vuetify from './plugins/vuetify';
import router from 'vue-router'

Vue.config.productionTip = false

const api = axios.create({
  baseURL: 'https://localhost:44395'
})

const axiosPluggin = {
  install(Vue) {
    Vue.prototype.$axios = api;
  }
}

Vue.use(axiosPluggin);

Vue.use(Vuetify);

export const bus = new Vue();

new Vue({
  vuetify,
  router,
  render: h => h(App)
}).$mount('#app')
