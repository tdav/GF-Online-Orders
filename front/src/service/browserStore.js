export const bStore = {
  delLocal(a) {
    localStorage.removeItem(a);
  },

  setLocal(a, v) {
    localStorage.setItem(a, JSON.stringify(v));
  },

  getLocal(v) {
    let u = localStorage.getItem(v);
    if (u && u != "undefined") return JSON.parse(u);
  },

  localClear() {
    sessionStorage.clear();
  },

  setSession(a, v) {
    sessionStorage.setItem(a, JSON.stringify(v));
  },

  getSession(a) {
    let u = sessionStorage.getItem(a);
    if (u) return JSON.parse(u);
  },

  sessionClear() {
    sessionStorage.clear();
  }
};
