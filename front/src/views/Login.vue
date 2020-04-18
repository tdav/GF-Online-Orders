<template>
  <v-app>
    <v-content>
      <v-container fluid fill-height>
        <v-layout align-center justify-center>
          <v-flex xs10 sm8 md5 lg4 xl3>
            <!-- <div class="primary dark parent" >
              <img src="../assets/image/logo.png" class="img-logo inner" alt="Лого" />
            </div> -->

            <v-card class="elevation-22 pa-3">
              <v-card-text>
                <v-form ref="loginForm">
                  <v-text-field
                    autofocus
                    append-icon="mdi-account-key"
                    name="login"
                    label="Логин"
                    type="text"
                    v-model="login"
                    required
                    :rules="[$valid.req]"
                  />
                  <v-text-field
                    append-icon="mdi-lock"
                    name="password"
                    label="Пароль"
                    id="password"
                    type="password"
                    v-model="password"
                    required
                    :rules="[$valid.req]"
                    @keyup.enter="dologin"
                  />
                </v-form>
              </v-card-text>
              <v-card-actions>
                <!-- <v-btn round to="reg">Регистрация</v-btn> -->
                <!-- <v-spacer></v-spacer> -->
                <v-btn
                  block
                  rounded
                  color="primary"
                  @click="dologin"
                  :loading="loading"
                >
                  Вход
                </v-btn>
              </v-card-actions>
            </v-card>
          </v-flex>
        </v-layout>
      </v-container>
    </v-content>
  </v-app>
</template>
<script>
import { bStore } from "../service/browserStore.js";

import { initStates } from "../store/_initStates";

export default {
  data: () => ({
    loading: false,
    login: "turopoff",
    password: "turopoff"
  }),

  methods: {
    dologin() {
      if (!this.$refs.loginForm.validate()) return;
      this.loading = true;

      let auth = {};
      auth.username = this.login;
      auth.password = this.password;

      this.$http.post("users/login", auth).then(res => {
        this.loading = false;
        if (!res) return alert("Неправильный пароль или ошибка соединения.");

        bStore.setLocal("userData", res);

        setTimeout(() => {
          initStates(this.$store);
          this.$router.push("/home");
        }, 1);
      });
    }
  }
};
</script>

<style scoped lang="css">
#login {
  height: 50%;
  width: 100%;
  position: absolute;
  top: 0;
  left: 0;
  content: "";
  z-index: 0;
}

.img-logo {
  width: 250px;
  height: 60px;
  object-fit: contain;
}

.parent {
  height: 80px;
  position: relative;
}

.inner {
  width: 320px;
  height: 100px;

  position: absolute;
  top: 50%;
  left: 50%;

  transform: translate(-50%, -50%);
}
</style>
