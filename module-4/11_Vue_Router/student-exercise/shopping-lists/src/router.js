import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home'
    },
    {
      path: '/products',
      name: 'products'
    },
    {
      path: '/on-sale',
      name: 'weekly-specials'
    },
    {
      path: '/cart',
      name: 'cart'
    },
    {
      path: '/checkout',
      name: 'checkout'
    },
  ]
})
