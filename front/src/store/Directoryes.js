import mutations from "./MutationActions/Directoryes.js";

import { http } from "../utils/fetch.config";
import { bStore } from "../service/browserStore.js";

export default {
  state: {
    districts: [],
    payments: [],
    orderStatus: []
  },

  mutations: {
    [mutations.setDistricts](state, districts) {
      bStore.setSession("districts", districts);

      state.districts = districts;
    },

    [mutations.setPayments](state, payments) {
      bStore.setSession("payments", payments);

      state.payments = payments;
    },

    [mutations.setOrderStatus](state, orderStatus) {
      bStore.setSession("orderStatus", orderStatus);

      state.orderStatus = orderStatus;
    }
  },

  actions: {
    [mutations.initDistricts]({ commit }) {
      let districts = bStore.getSession("districts");
      if (Array.isArray(districts)) {
        commit(mutations.setDistricts, districts);
      } else {
        http.get("districts").then(res => {
          commit(mutations.setDistricts, Array.isArray(res) ? res : []);
        });
      }
    },

    [mutations.setDistricts]({ commit }, districts) {
      commit(mutations.setDistricts, districts);
    },

    [mutations.initPayments]({ commit }) {
      let payments = bStore.getSession("payments");
      if (Array.isArray(payments)) {
        commit(mutations.setPayments, payments);
      } else {
        http.get("payments").then(res => {
          commit(mutations.setPayments, Array.isArray(res) ? res : []);
        });
      }
    },

    [mutations.setPayments]({ commit }, payments) {
      commit(mutations.setPayments, payments);
    },

    [mutations.initOrderStatus]({ commit }) {
      let orderStatus = bStore.getSession("orderStatus");
      if (Array.isArray(orderStatus)) {
        commit(mutations.setOrderStatus, orderStatus);
      } else {
        http.get("orderStatus").then(res => {
          commit(mutations.setOrderStatus, Array.isArray(res) ? res : []);
        });
      }
    },

    [mutations.setOrderStatus]({ commit }, orderStatus) {
      commit(mutations.setOrderStatus, orderStatus);
    }
  },

  getters: {
    [mutations.getDistricts](state) {
      return state.districts;
    },

    [mutations.getPayments](state) {
      return state.payments;
    },

    [mutations.getOrderStatus](state) {
      return state.orderStatus;
    }
  }
};
