import React from 'react';
import axios from 'axios';
import './App.css';

class App extends React.Component {
  state = {
    posts: []

  }

  componentWillMount() {
    axios.get('http://localhost:5000/api/values')
    .then((response) => {
      this.setState({
        posts: response.data

      })

    }) .catch((error) => {
      console.error('Error fetching data: ${error}')

    })

  }

  render() {
    const { posts } = this.state;

    return (
      <div className="App">
        <header className="App-header">
          BlogBox

        </header>

        <main>
          {posts.map((value: any) => 
            <div key={post.id}>
              <h1>{posts.title}</h1>
              <p>{posts.body}</p>
              
            </div>

          )}

        </main>

      </div>

    );
  }

}

export default App;
