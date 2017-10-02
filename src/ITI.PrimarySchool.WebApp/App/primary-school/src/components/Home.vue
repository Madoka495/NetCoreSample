<template>
    <div class="jumbotron">
        <h1>Bienvenue sur ITI.PrimarySchool</h1>

        <p>
            Cette application est réalisée à l'aide du framework Vue 2
        </p>

        <p>
            <a class="btn btn-primary btn-lg" href="http://vuejs.org/v2/guide/" role="button">Guide Vue 2</a>
            <a class="btn btn-primary btn-lg" href="http://vuejs.org/v2/api/" role="button">Documentation API Vue 2</a>
        </p>

        <div v-if="show">
            {{ message }}
        </div>

        <div v-show="show">
            {{ message }}
        </div>

        <ul>
            <li v-for="color in colorList">
                {{ color }}
            </li>
        </ul>

        Color to add: <input type="text" v-model="colorToAdd" />
        <button type="button" @click="addColor()">Add</button>

        <hr />

        <button type="button" @click="enableShow()">Show message</button>

        <br />

        X: <input type="number" v-model.number="x"/> Y: <input type="number" v-model.number="y" />

        <br /> TOTAL: {{ total }}

        <hr />

        Alert message: <input type="text" v-model="alertMessage" />

        <iti-alert :message="alertMessage" type="success"></iti-alert>
    </div>
</template>

<script>
    import ItiAlert from './ItiAlert.vue'

    export default {
        components: {
            ItiAlert
        },

        data() {
            return {
                message: null,
                x: 0,
                y: 0,
                show: false,
                colorList: [],
                colorToAdd: null,
                alertMessage: null
            }
        },

        mounted() {
            this.message = new Date().toString();
            this.colorList = ["red", "green", "blue"];
        },

        methods: {
            enableShow() {
                this.show = true;
            },

            addColor() {
                if(!this.colorToAdd) {
                    alert('Error');
                }
                else {
                    this.colorList.push(this.colorToAdd);
                    this.colorToAdd = '';
                }
            }
        },

        computed: {
            total() {
                return this.x + this.y;
            }
        }
    }
</script>

<style lang="less">

</style>