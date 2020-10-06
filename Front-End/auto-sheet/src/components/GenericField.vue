<template>
    <div v-if="type==='text'">
        <v-text-field :ref="id" v-model="textField" :label="label" :color="color" :outlined="outlined"
            :clearable="clearable">
        </v-text-field>
    </div>
    <div v-else-if="type==='integer'">
        <v-text-field :ref="id" v-model="numberField" type="number" :label="label" :color="color" :outlined="outlined"
            :clearable="clearable"></v-text-field>
    </div>
    <div v-else-if="type==='select'">
        <v-select :ref="id" :items="selectOptions" v-model="selectField" :label="label" :color="color"
            :outlined="outlined">
        </v-select>
    </div>
</template>

<script>
    import {
        bus
    } from '../main'
    export default {
        props: {
            id: String,
            type: String,
            label: String,
            color: String,
            outlined: Boolean,
            clearable: Boolean,
            startValue: Object,
            selectOptions: Array
        },
        data: () => ({
            textField: null,
            numberField: null,
            selectField: null
        }),
        created() {
            this.$root.$on(`cleanFields`, () => {
                this.textField = null;
                this.numberField = null;
                this.selectField = null;
            });

            this.initFields();
        },
        beforeDestroy() {
            bus.$off('cleanFields')
        },
        methods: {
            initFields() {
                if (this.type === 'text') {
                    this.textField = this.startValue ? this.startValue.value : null;
                } else if (this.type === 'integer') {
                    this.numberField = this.startValue ? parseInt(this.startValue.value) : null;
                } else if (this.type === 'select') {
                    this.selectField = this.startValue ? this.startValue.value : null;
                }
            }
        },
        watch: {
            textField: {
                handler: function (val) {
                    this.$emit('updateField', {
                        id: this.id,
                        value: val
                    })
                }
            },
            numberField: {
                handler: function (val) {
                    this.$emit('updateField', {
                        id: this.id,
                        value: parseInt(val)
                    })
                }
            },
            selectField: {
                handler: function (val) {
                    this.$emit('updateField', {
                        id: this.id,
                        value: val
                    })
                }
            }
        }
    }
</script>