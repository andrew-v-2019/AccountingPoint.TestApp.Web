
<template>
    <div class="container">
        <h1>
            buttonsCount {{buttonsCount}}
        </h1>

        <div :class="button"> Кнопка </div>
    </div>
</template>

<script>
    export default {
        props: {
            buttonsCount: {
                type: Number
            }
        },
        created: function () {

        },
    }
</script>


<style lang="scss">
    .button {
        background-color: #0094ff !important;
        font-size: 50px;
    }
</style>

