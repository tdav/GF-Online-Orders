import mutations from "./MutationActions/OrdersHistory.js";

export default {
  state: {
    ordersHistory: []
  },

  mutations: {
    [mutations.setOrders](state, orders) {
      state.ordersHistory = orders;
    }
  },

  actions: {
    [mutations.setOrders]({ commit }, orders) {
      commit(mutations.setOrders, orders);
    }
  },

  getters: {
    [mutations.getOrders](state) {
      return state.ordersHistory;
    }
  }
};
