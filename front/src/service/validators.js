const valid = {
  req: v => !!v || ""
};

import Vue from "vue";

Vue.prototype.$valid = valid;
