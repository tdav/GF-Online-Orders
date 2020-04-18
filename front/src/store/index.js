import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

import { initStates } from "./_initStates";

import OrdersHistory from "./OrdersHistory.js";
import Directoryes from "./Directoryes.js";

const store = new Vuex.Store({
  modules: [OrdersHistory, Directoryes],
  state: {},
  mutations: {},
  actions: {}
});

initStates(store);

export default store;
