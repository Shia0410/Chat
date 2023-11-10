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
export default {
  data() {
    return {
      username: '',
      password: ''
    };
  },
  methods: {
    login() {
        axios.post('http://localhost/User/login', {
        username: this.username,
        password: this.password
      })
      .then(response => {
        // Handle successful login
        console.log('Login successful');
      })
      .catch(error => {
        // Handle login error
        console.error('Login failed', error);
      });
    }
  }
};
</script>
