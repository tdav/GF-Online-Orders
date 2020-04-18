<template>
  <div>
    <v-menu
      :close-on-content-click="false"
      transition="scale-transition"
      v-model="dateBox"
      width="290"
    >
      <template v-slot:activator="{ on }">
        <v-text-field
          dense
          :class="classB"
          readonly
          v-on="on"
          :label="title"
          :rules="[$valid.req]"
          :style="{ width: width + 'px' }"
          v-model="dateFormatted"
          outlined
          hide-details=true
        >
          <v-icon v-on="on" slot="append">mdi-calendar</v-icon>
        </v-text-field>
      </template>
      <v-date-picker
        :allowed-dates="allowedDates"
        @input="updateParam"
        first-day-of-week="1"
        :allowedDates="allowedDates"
        scrollable
        v-model="date"
      ></v-date-picker>
    </v-menu>
  </div>
</template>

<script>
import { tools } from "../service/tools.js";

export default {
  props: ["title", "model", "classB", "width", "allowedDates", "rules"],

  data() {
    return {
      dateBox: false,
      date: null,
      dateFormatted: null
    };
  },

  watch: {
    date() {
      this.dateFormatted = this.formatDateDot(this.date);
      this.$emit("model", tools.formatDate(this.date));
    }
  },

  created() {
    this.date = this.model;
  },

  methods: {
    formatDateDot(date) {
      if (!date || (date && date.length > 10)) return null;
      let [year, month, day] = date.split("-");
      return `${day}.${month}.${year}`;
    },

    updateParam() {
      this.dateBox = false;
    }
  }
};
</script>

<style>
.v-input input[type="date"]::-webkit-inner-spin-button,
.v-input input[type="date"]::-webkit-calendar-picker-indicator,
.v-input input[type="date"]::-webkit-clear-button {
  display: none;
  -webkit-appearance: none;
}
</style>
