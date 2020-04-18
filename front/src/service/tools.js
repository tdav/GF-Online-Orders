import { bStore } from "./browserStore";

export const tools = {
  getRealDate(days, month) {
    let date = new Date();

    if (days) {
      date.setDate(date.getDate() + days);
    }

    if (month) {
      date.setMonth(date.getMonth() + month);
    }

    return date.toISOString().substr(0, 10);
  },

  formatDate(date) {
    if (!date || (date && date.length > 10)) return null;
    let [year, month, day] = date.split("-");
    return `${year}-${month}-${day}`;
  },

  strToNum(strNum) {
    return Number(strNum) ? Number(strNum) : 0;
  },

  getToken() {
    let token = null;

    const userData = bStore.getLocal("userData");
    if (userData) {
      token = userData.token;
    }

    return token ? `bearer ${token}` : null;
  }
};
