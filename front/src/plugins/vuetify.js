import Vue from "vue";

import Vuetify from "vuetify/lib";
import ru from "vuetify/src/locale/ru.ts";
// import en from 'vuetify/src/locale/en.ts';

Vue.use(Vuetify);

const opts = {
  lang: {
    locales: {
      ru
    },
    current: "ru"
  },

  theme: {},

  options: {
    customProperties: true
  }
};

export default new Vuetify(opts);
