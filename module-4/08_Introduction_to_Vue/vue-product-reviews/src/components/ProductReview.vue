<template>
    <div class="main"> 
        <h2>Product Reviews for {{ name }}</h2>
        <p class="description">{{ description }}</p>
    </div>
</template>

<style scoped>
    div.main {
        margin: 1rem 0;
    }
</style>

<script>
    export default {
        name: 'product-review',
        data() {
            return {
                name: 'Cigar Parties for Dummies',
                description: 'Host and plan the perfect cigar party for all of your squirrelly friends.'
            }
        }
    }
</script>