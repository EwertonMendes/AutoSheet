<template>
  <div id="app">
    <v-app id="auto-sheet">

      <v-navigation-drawer class="mt-16" mini-variant absolute permanent clipped dark>
        <v-list nav>
          <v-list-item-group v-model="group" active-class="teal--text text--accent-4">
            <v-list-item>
              <v-list-item-icon>
                <v-icon>mdi-home</v-icon>
              </v-list-item-icon>
              <v-list-item-title>Home</v-list-item-title>
            </v-list-item>

            <v-list-item>
              <v-list-item-icon>
                <v-icon>mdi-account</v-icon>
              </v-list-item-icon>
              <v-list-item-title>Account</v-list-item-title>
            </v-list-item>
          </v-list-item-group>
        </v-list>
      </v-navigation-drawer>

      <v-app-bar app clipped-left color="teal" dark>
        <v-toolbar-title>Auto Sheet - V 0.0.1</v-toolbar-title>
      </v-app-bar>

      <v-main class="background">
        <v-container  fluid>
          <router-view/>
          <Ficha></Ficha>

        </v-container>
      </v-main>
    </v-app>
  </div>

</template>

<script>
import Ficha from './components/Ficha'
  export default {
    components: {
      Ficha
    },
    data: () => ({
      drawer: true,
      group: null,
    }),
  }
</script>

<style scoped>
  
</style>

<style>
  .background {
    background-color: var(--v-background-lighten2);
  }
  .right {
    position: absolute;
    right: -6%;
    width: 10%;
  }
</style>