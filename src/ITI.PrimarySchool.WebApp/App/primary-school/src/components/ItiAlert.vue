<template>
    <div :class="getCssClass" class="alert" role="alert">
        {{ message }}
    </div>
</template>

<script>
export default {
    props: [
        'message',
        'type'
    ],

    computed: {
        getCssClass() {
            return `alert-${this.type}`;
        }
    }
}
</script>

<style>

</style>