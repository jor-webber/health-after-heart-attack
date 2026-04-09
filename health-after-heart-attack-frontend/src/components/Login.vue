<template>
  <v-container class="d-flex align-center justify-center" style="height: 100vh;">
    <v-card class="pa-6" style="width: 100%; max-width: 500px;">
      <v-card-title class="text-h5 text-center">Login</v-card-title>
      <v-card-text>
        <v-form @submit.prevent="handleLogin">
          <v-text-field
            v-model="username"
            label="Username"
            required
          ></v-text-field>
          <v-text-field
            v-model="password"
            label="Password"
            type="password"
            required
          ></v-text-field>
          <v-btn type="submit" color="primary" block>Login</v-btn>
        </v-form>
      </v-card-text>
    </v-card>
  </v-container>
</template>

<script setup>
import { ref } from 'vue';

const username = ref('');
const password = ref('');

const handleLogin = () => {
  // Placeholder for login logic
  console.log('Logging in with', username.value, password.value);
};
</script>

<style scoped>
/* Vuetify handles most of the styling */
</style>