<template>
  <div id="app">
    <a href="#" id="increase" class="btn" v-on:click="updateCounter(2,$event)"
      >Increase</a
    >
    <a href="#" id="decrease" class="btn" v-on:click="updateCounter(2,$event)"
      >Decrease</a
    >
    <p>The button was clicked {{ counter }} times</p>
  </div>
</template>

<script>
export default {
  name: "app",
  data() {
    return {
      order: {
            firstName: '',
            lastName: '',
            shippingAddressOne: '',
            shippingAddressTwo: '',
            shippingCity: '',
            shippingState: '',
            shippingZip: '',
            billingAddressOne: '',
            billingAddressTwo: '',
            billingCity: '',
            billingState: '',
            billingZip:'',
            creditCardNumber: '',
            creditCardType: '',
            expDate: ''
        },
        sameAddress: false,
        creditLogoSrc: '../assets/credit.png',

    };
  },
  methods: {
    updateCounter(amount, event) {
      if(event.target.id === "increase") {
        this.counter += amount;
      } else {
        this.counter -= amount;
      }
    }
  }
};
</script>

<style>
  body {
    margin: 10px;
  }
  a.btn {
    display: inline-block;
    margin: 10px;
    padding: 12px;
    font-size: 13px;
    font-weight: 700;
    background-color: rgb(63, 63, 219);
    color: white;
    text-decoration: none;
    text-transform: uppercase;
    border-radius: 4px;
  }
</style>
