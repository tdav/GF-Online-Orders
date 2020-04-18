import spMutation from "./MutationActions/Directoryes";

const actions = [
  spMutation.initDistricts,
  spMutation.initPayments,
  spMutation.initOrderStatus
];

// import { sysConfig } from "../utils/staticConfig";
import { tools } from "../service/tools";

export const initStates = store => {
  // let localVersion = localStorage.getItem("localVersion");

  // if (localVersion != sysConfig.localVersion) {
  //   localStorage.clear();
  //   setTimeout(() => {
  //     localStorage.setItem("localVersion", sysConfig.localVersion);
  //   }, 1);
  // }

  if (tools.getToken()) actions.forEach(action => store.dispatch(action));
};
