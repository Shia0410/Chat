<template>
  <div>
    <h2>Login</h2>
    <form @submit.prevent="login">
      <label for="username">Username:</label>
      <input type="text" v-model="username" required />
      <br />
      <label for="password">Password:</label>
      <input type="password" v-model="password" required />
      <br />
      <button type="submit">Login</button>
    </form>
  </div>
</template>

<script>
import axios from "axios";

export default {
  data() {
    return {
      username: '',
      password: ''
    };
  },
  methods: {
    async login() {
      try {
        const response = await axios.post('https://localhost:7171/api/User/login', {
          _username: this.username,
          _password: this.password
        });

        // Assuming your API returns some data upon successful login
        console.log('Login successful', response.data);
        
        // Optionally, you might want to redirect the user to another page or perform other actions on success.

      } catch (error) {
        // Handle login error
        console.error('Login failed', error);
        
        // Optionally, you might want to display an error message to the user or perform other actions on failure.
      }
    }
  }
};
</script>
