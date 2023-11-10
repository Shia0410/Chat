<template>
  <div>
    <h2>Login</h2>
    <form @submit.prevent="login">
      <label for="username">Username:</label>
      <input type="text" v-model="user" required />
      <br />
      <label for="password">Password:</label>
      <input type="password" v-model="pass" required />
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
      user: '',
      pass: ''
    };
  },
  methods: {
  login() {
    const apiUrl = 'http://localhost:7171/api/User/login'; // replace with your actual API endpoint

    const requestData = {
      "_username": this.username,
      "_password": this.password
    };

    axios.post(apiUrl, requestData)
      .then(response => {
        // Handle successful response
        console.log('API response:', response.data);
      })
      .catch(error => {
        // Handle error
        console.error('API error:', error);
      });
  }
}
};
</script>
