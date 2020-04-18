export const date = stringdate => {
  let date = new Date();

  if (stringdate) date = new Date(stringdate);

  let [year, month, day] = date
    .toISOString()
    .substr(0, 10)
    .split("-");

  return `${day.padStart(2, "0")}.${month.padStart(2, "0")}.${year}`;
};

export const sum = value => {
  return value ? value.toString().replace(/\B(?=(\d{3})+(?!\d))/g, " ") : 0;
};

import Vue from "vue";
Vue.filter("date", date);
Vue.filter("sum", sum);
