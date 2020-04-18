<template>
  <div>
    <v-navigation-drawer
      v-model="drawer"
      :clipped="$vuetify.breakpoint.lgAndUp"
      app
    >
      <v-list dense>
        <template v-for="item in navItems">
          <v-row v-if="item.heading" :key="item.heading" align="center">
            <v-col cols="6">
              <v-subheader v-if="item.heading">{{ item.heading }}</v-subheader>
            </v-col>
            <v-col cols="6" class="text-center">
              <a href="#!" class="body-2 black--text">EDIT</a>
            </v-col>
          </v-row>
          <v-list-group
            v-else-if="item.children"
            :key="item.text"
            v-model="item.model"
            :prepend-icon="item.model ? item.icon : item['icon-alt']"
            append-icon
          >
            <template v-slot:activator>
              <v-list-item-content>
                <v-list-item-title>{{ item.text }}</v-list-item-title>
              </v-list-item-content>
            </template>
            <v-list-item v-for="(child, i) in item.children" :key="i" link>
              <v-list-item-action v-if="child.icon">
                <v-icon>{{ child.icon }}</v-icon>
              </v-list-item-action>
              <v-list-item-content>
                <v-list-item-title>{{ child.text }}</v-list-item-title>
              </v-list-item-content>
            </v-list-item>
          </v-list-group>
          <v-list-item v-else :key="item.text" link>
            <v-list-item-action>
              <v-icon>{{ item.icon }}</v-icon>
            </v-list-item-action>
            <v-list-item-content>
              <v-list-item-title>{{ item.text }}</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
        </template>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar
      :clipped-left="$vuetify.breakpoint.lgAndUp"
      app
      color="blue darken-3"
      dark
    >
      <v-app-bar-nav-icon @click.stop="drawer = !drawer" />
      <v-toolbar-title style="width: 300px" class="ml-0 pl-4">
        <span class="hidden-sm-and-down">Pharmacy</span>
      </v-toolbar-title>

      <!-- <v-spacer />
      <v-text-field
        flat
        solo-inverted
        hide-details
        prepend-inner-icon="mdi-magnify"
        label="Search"
        class="hidden-sm-and-down"
      />-->
    </v-app-bar>

    <v-content>
      <v-container>
        <v-row>
          <div class="w-100 px-3">
            <div>
              Доставка
            </div>
          </div>
          <v-col class="pb-0" cols="3">
            <v-select
              :items="districts"
              dense
              label="Район"
              outlined
              item-text="name"
              item-value="id"
              v-model="ordersFilter.districtId"
            />
          </v-col>
          <v-col class="pb-0" cols="2">
            <DatePicker
              :model="ordersFilter.deliveryTime1"
              @model="e => ordersFilter.deliveryTime1"
              title="От"
            />
          </v-col>

          <v-col class="pb-0" cols="2">
            <DatePicker
              :model="ordersFilter.deliveryTime2"
              @model="e => ordersFilter.deliveryTime2"
              title="До"
            />
          </v-col>
          <v-col class="pb-0" cols="2">
            <v-select
              :items="payments"
              dense
              label="Тип оплаты"
              outlined
              item-text="name"
              item-value="id"
              v-model="ordersFilter.paymentId"
            />
          </v-col>
        </v-row>
        <v-row>
          <div class="w-100 px-3">
            <div>
              Заказ
            </div>
          </div>
          <v-col class="pb-0" cols="2">
            <DatePicker
              :model="ordersFilter.createDate1"
              @model="e => ordersFilter.createDate1"
              title="От"
            />
          </v-col>
          <v-col class="pb-0" cols="2">
            <DatePicker
              :model="ordersFilter.createDate2"
              @model="e => ordersFilter.createDate2"
              title="До"
            />
          </v-col>
          <v-col class="pb-0" cols="2">
            <v-btn :loading="loading" @click="onRefresh" color="primary" dark>
              Обновить
            </v-btn>
          </v-col>
        </v-row>
        <v-row>
          <v-col cols="8">
            <v-data-table
              :loading="loading"
              :headers="tbOrderHeaders"
              :items="orders"
              item-key="id"
              class="elevation-1"
            >
              <template v-slot:body="props">
                <tbody>
                  <tr
                    class="c-pointer"
                    @click="onSelectOrder(item)"
                    :class="item.id == selectedOrder.id ? 'dt-active' : ''"
                    :key="key"
                    v-for="(item, key) in props.items"
                  >
                    <td>{{ item.drugStoreName }}</td>
                    <td>{{ getFullAddress(item) }}</td>
                    <td>{{ item.description }}</td>
                    <td>{{ item.deliveryTime | date }}</td>
                    <td>{{ item.deliveryTypeName }}</td>
                    <td>{{ item.orderStatusName }}</td>
                    <td>{{ item.paymentName }}</td>
                    <td>{{ item.userAgentName }}</td>
                    <td>{{ item.createDate | date }}</td>
                  </tr>
                </tbody>
              </template>
            </v-data-table>
          </v-col>
          <v-col cols="4">
            <v-data-table
              :loading="loading"
              :headers="tbOrderDetailsHeaders"
              :items="orderDetails"
              item-key="id"
              class="elevation-1"
            >
              <template v-slot:item.price="{ item }">
                <span class="text_nowrap">{{ item.price | sum }}</span>
              </template>
              <template v-slot:item.qty="{ item }">
                <span class="text_nowrap">{{ item.qty | sum }}</span>
              </template>
              <template v-slot:item.totalSum="{ item }">
                <span class="text_nowrap">{{ item.totalSum | sum }}</span>
              </template>
            </v-data-table>
          </v-col>
        </v-row>
      </v-container>
    </v-content>
  </div>
</template>

<script>
import mutations from "../store/MutationActions/OrdersHistory";
import spMutations from "../store/MutationActions/Directoryes";
import { tools } from "../service/tools.js";

import DatePicker from "../components/DatePicker.vue";

export default {
  components: {
    DatePicker
  },

  data: () => ({
    tools,
    tbOrderHeaders: [
      {
        text: "Аптека",
        value: "drugStoreName"
      },
      {
        text: "Адрес",
        value: "addressName",
        minWidth: 200
      },
      {
        text: "Описание",
        value: "description"
      },
      {
        text: "Срок поставки",
        value: "deliveryTime"
      },
      {
        text: "Тип доставки",
        value: "deliveryTypeName"
      },
      {
        text: "Статус",
        value: "orderStatusName"
      },
      {
        text: "Оплата",
        value: "paymentName"
      },
      {
        text: "Пользователь",
        value: "userAgentName"
      },
      {
        text: "createDate",
        value: "createDate"
      }
    ],

    tbOrderDetailsHeaders: [
      {
        text: "Лекарство",
        value: "drugName",
        minWidth: 200
      },
      {
        text: "Цена",
        value: "price"
      },
      {
        text: "Колво.",
        value: "qty"
      },
      {
        text: "Сумма",
        value: "totalSum"
      }
    ],

    drawer: false,
    navItems: [
      { icon: "mdi-history", text: "Заказлар" },
      { icon: "mdi-contacts", text: "Категории" },
      { icon: "mdi-sitemap", text: "Поставщики" },
      { icon: "mdi-package-variant", text: "Мой профиль" },
      { icon: "mdi-help-circle", text: "Тех. поддержка" },
      { icon: "mdi-alert-circle-outline", text: "О приложения" },
      { icon: "mdi-keyboard", text: "Выход" }
    ],

    ordersFilter: {
      drugStoreId: 0,
      districtId: 0,
      deliveryTime1: tools.getRealDate(0, -1),
      deliveryTime2: tools.getRealDate(),
      orderStatusId: 0,
      paymentId: 0,
      userAgentId: 0,
      createUser: 0,
      createDate1: tools.getRealDate(0, -1),
      createDate2: tools.getRealDate()
    },

    loading: false,
    selectedOrder: []
  }),

  computed: {
    orders: {
      get: vm => vm.$store.getters[mutations.getOrders],

      set(v) {
        this.$store.dispatch(mutations.setOrders, v);
      }
    },

    orderDetails: {
      get: vm => (vm.selectedOrder.id ? vm.selectedOrder.orderDetails : [])
    },

    districts() {
      let districts = this.$store.getters[spMutations.getDistricts];
      return districts.filter(x => x.regionId == 10);
    },

    payments: vm => vm.$store.getters[spMutations.getPayments]
  },

  created() {
    this.onRefresh();
  },

  methods: {
    onRefresh() {
      this.loading = true;

      this.$http.post("order/filter", this.ordersFilter).then(res => {
        this.loading = false;
        this.orders = Array.isArray(res) ? res : [];
        this.selectedOrder = this.orders.length ? this.orders[0] : {};
      });
    },

    onSelectOrder(e) {
      this.selectedOrder = e;
    },

    getFullAddress(item) {
      let adrs = {
        regionName: item.regionName,
        districtName: item.districtName,
        street: item.street,
        house: item.house,
        flat: item.flat,
        waymark: item.waymark
      };

      return Object.keys(adrs)
        .filter(key => adrs[key] && adrs[key].trim())
        .map(key => adrs[key])
        .join(", ");
    }
  }
};
</script>

<style>
.w-100 {
  width: 100%;
}

.c-pointer {
  cursor: pointer;
}

.dt-active {
  background-color: #d4d4d4 !important;
}

.text_nowrap {
  white-space: nowrap;
}
</style>
