<template>
  <div class="container">
    <div class="row">
      <div class="col-8">
        <form>
          <div class="form-row">
            <h2>Shipping Address</h2>
          </div>
          <div class="form-group">
            <label for="shippingAddress">Address</label>
            <input
              type="text"
              v-model="shipping.address"
              class="form-control"
              id="shippingAddress"
              placeholder="1234 Main St"
            >
          </div>
          <div class="form-group">
            <label for="shippingAddress2">Address 2</label>
            <input
              type="text"
              v-model="shipping.address2"
              class="form-control"
              id="shippingAddress2"
              placeholder="Apartment, studio, or floor"
            >
          </div>
          <div class="form-row">
            <div class="form-group col-md-6">
              <label for="shippingCity">City</label>
              <input type="text" v-model="shipping.city" class="form-control" id="shippingCity">
            </div>
            <div class="form-group col-md-4">
              <label for="shippingState">State</label>
              <select id="shippingState" v-model="shipping.state" class="form-control">
                <option value="" selected>Choose...</option>
                <option value="MI">MI</option>
                <option value="OH">OH</option>
                <option value="PA">PA</option>
              </select>
            </div>
            <div class="form-group col-md-2">
              <label for="shippingZip">Zip</label>
              <input type="text" v-model="shipping.zip" class="form-control" id="shippingZip">
            </div>
          </div>
          <div class="form-row">
            <div class="form-group col-md-4">
              <label for="deliverto">Deliver Package to:</label>
              <div class="form-check">
                <input
                  class="form-check-input"
                  type="radio"
                  v-model="shipping.deliverto"
                  name="deliverto"
                  id="delivertoFrontDoor"
                  value="Front Door"
                  checked
                >
                <label class="form-check-label" for="delivertoFrontDoor">Front Door</label>
              </div>
              <div class="form-check">
                <input
                  class="form-check-input"
                  type="radio"
                  v-model="shipping.deliverto"
                  name="deliverto"
                  id="delivertoSideDoor"
                  value="Side Door"
                >
                <label class="form-check-label" for="delivertoSideDoor">Side Door</label>
              </div>
              <div class="form-check">
                <input
                  class="form-check-input"
                  type="radio"
                  v-model="shipping.deliverto"
                  name="deliverto"
                  id="delivertoBackDoor"
                  value="Back Door"
                >
                <label class="form-check-label" for="delivertoBackDoor">Back Door</label>
              </div>
            </div>
          </div>

          <div class="form-group">
            <div class="form-check">
              <input
                class="form-check-input"
                type="checkbox"
                v-mod="billingSameAsShipping"
                id="billingSameCheckbox"
                :checked="billingSameAsShipping"
                v-on:change="updateBilling"
              >
              <label class="form-check-label" for="billingSameCheckbox">Billing same as shipping</label>
            </div>
          </div>

          <div class="billing-add" v-if="!billingSameAsShipping">
            <div class="form-row">
              <h2>Billing Address</h2>
            </div>
            <div class="form-group">
              <label for="billingAddress">Address</label>
              <input
                type="text"
                v-model="billing.address"
                class="form-control"
                id="billingAddress"
                placeholder="1234 Main St"
              >
            </div>
            <div class="form-group">
              <label for="billingAddress2">Address 2</label>
              <input
                type="text"
                v-model="billing.address2"
                class="form-control"
                id="billingAddress2"
                placeholder="Apartment, studio, or floor"
              >
            </div>
            <div class="form-row">
              <div class="form-group col-md-6">
                <label for="billingCity">City</label>
                <input type="text" v-model="billing.city" class="form-control" id="billingCity">
              </div>
              <div class="form-group col-md-4">
                <label for="billingState">State</label>
                <select id="billingState" v-model="billing.state" class="form-control">
                  <option value="" selected>Choose...</option>
                  <option value="MI">MI</option>
                  <option value="OH">OH</option>
                  <option value="PA">PA</option>
                </select>
              </div>
              <div class="form-group col-md-2">
                <label for="billingZip">Zip</label>
                <input type="text" v-model="billing.zip" class="form-control" id="billingZip">
              </div>
            </div>
          </div>

          <button type="submit" class="btn btn-primary float-right">Next Step</button>
        </form>
      </div>
      <div class="col">
        <div class="results">
          <h3>Shipping Address</h3>
          <div class="line-item">
            Address:
            <span class="shipping-address">{{ shipping.address }}</span>
          </div>
          <div class="line-item">
            Address 2:
            <span class="shipping-address2">{{ shipping.address2 }}</span>
          </div>
          <div class="line-item">
            City:
            <span class="shipping-city">{{ shipping.city }}</span>
          </div>
          <div class="line-item">
            State:
            <span class="shipping-state">{{ shipping.state }}</span>
          </div>
          <div class="line-item">
            Zip:
            <span class="shipping-zip">{{ shipping.zip }}</span>
          </div>
          <div class="line-item">
            Deliver to:
            <span class="shipping-deliverto">{{ shipping.deliverto }}</span>
          </div>

          <h3>Billing Address</h3>
          <div class="line-item">
            Address:
            <span class="billing-address">{{ billing.address }}</span>
          </div>
          <div class="line-item">
            Address 2:
            <span class="billing-address2">{{ billing.address2 }}</span>
          </div>
          <div class="line-item">
            City:
            <span class="billing-city">{{ billing.city }}</span>
          </div>
          <div class="line-item">
            State:
            <span class="billing-state">{{ billing.state }}</span>
          </div>
          <div class="line-item">
            Zip:
            <span class="billing-zip">{{ billing.zip }}</span>
          </div>

        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'address-info',
  data() {
    return {
      billingSameAsShipping: false,
      shipping: [
        { address: '' },
        { address2: '' },
        { city: '' },
        { state: '' },
        { zip: '' },
        { deliverto: '' },
      ],
      billing: [
        { address: '' },
        { address2: '' },
        { city: '' },
        { state: '' },
        { zip: '' },
      ]
    };
  },
  methods: {
    updateBilling() {
      console.log('I am called when the checkbox "Billing same as shipping" is checked or unchecked.');
      this.billingSameAsShipping = !this.billingSameAsShipping;
      // if billingSameAsShipping set billing equal to shipping
      if(this.billingSameAsShipping){
        this.billing.address = this.shipping.address;
        this.billing.address2 = this.shipping.address2;
        this.billing.city = this.shipping.city;
        this.billing.state = this.shipping.state;
        this.billing.zip = this.shipping.zip;
      } else {
          this.billing.address = '';
          this.billing.address2 = '';
          this.billing.city = '';
          this.billing.state = '';
          this.billing.zip = '';
      }
      // else clear all the billing address fields
    },
    clearBillingAddress() {
      // clear the billing address fields
          this.billing.address = '';
          this.billing.address2 = '';
          this.billing.city = '';
          this.billing.state = '';
          this.billing.zip = '';
    }
  }
};
</script>

<style>
.results {
  background-color: rgb(231, 231, 231);
  height: 100%;
  border-radius: 10px;
  padding: 10px;
}
.results h3:not(:first-child) {
  margin-top:20px;
}
</style>
