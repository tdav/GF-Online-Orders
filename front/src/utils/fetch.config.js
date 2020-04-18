import { sysConfig } from "./staticConfig";
import { tools } from "../service/tools";

import router from "../router";

const serverUrl = `${sysConfig.serverUrl}/api/`;

export const http = {
  async postForm(url, data) {
    try {
      const res = await fetch(serverUrl + url, {
        method: "POST",
        headers: getReqHeader(),
        body: data
      });

      if (catchErrors(res)) return null;

      return returnResult(res);
    } catch (e) {
      alert(e);

      return null;
    }
  },

  async post(url, data) {
    try {
      const res = await fetch(serverUrl + url, {
        method: "POST",
        headers: getReqHeader(),
        body: JSON.stringify(data)
      });

      return returnResult(res);
    } catch (e) {
      alert(e);

      return null;
    }
  },

  async put(url, data) {
    try {
      const res = await fetch(serverUrl + url, {
        method: "PUT",
        headers: getReqHeader(),
        body: JSON.stringify(data)
      });

      if (catchErrors(res)) return null;

      return returnResult(res);
    } catch (e) {
      alert(e);

      return null;
    }
  },

  async get(url) {
    try {
      const res = await fetch(serverUrl + url, {
        method: "GET",
        headers: getReqHeader()
      });

      if (catchErrors(res)) return null;

      return returnResult(res);
    } catch (e) {
      alert(e);

      return null;
    }
  },

  async delete(url) {
    try {
      const res = await fetch(serverUrl + url, {
        method: "DELETE",
        headers: getReqHeader()
      });

      if (catchErrors(res)) return null;

      return returnResult(res);
    } catch (e) {
      alert(e);

      return null;
    }
  }
};

import Vue from "vue";

Vue.prototype.$http = http;

function getReqHeader() {
  return {
    "Access-Control-Allow-Origin": "*",
    "Access-Control-Allow-Methods": "POST, GET, PUT, OPTIONS, DELETE",
    "Access-Control-Allow-Headers": `Access-Control-Allow-Methods, Access-Control-Allow-Origin, Origin, Accept, Content-Type`,
    "Content-Type": "application/json;charset=utf-8",
    Accept: "application/json",
    Authorization: tools.getToken()
  };
}

async function returnResult(res) {
  try {
    let resJson = await res.json();

    return resJson && !resJson.statusMessage ? resJson : null;
  } catch {
    return null;
  }
}

function catchErrors(res) {
  const status = res.status;

  switch (status) {
    case 500:
      alert("Ошибка соединения с сервером");
      return true;
    case 400:
      sessionStorage.removeItem("token");
      if (router.currentRoute.path != "/") {
        return router.push("/");
      }
      return true;
  }

  return false;
}
