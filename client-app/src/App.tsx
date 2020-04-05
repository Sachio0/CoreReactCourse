import React, {Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { cars } from './demo';
import CarItem from './CarItem';
import axios from 'axios';
import { Header, Icon, List } from 'semantic-ui-react'
class App extends Component {
    state = {
        values: []
    }

    componentDidMount() {
        axios.get("https://localhost:44335/API/values").
            then((response) => {
                this.setState({
                    values: response.data
                })
            })
        this.setState({
            values: [{ id: 1, name: "Values 1" }, { id: 2, name: "Values 2" }]
        })
    }

    render() {
        return (
            <div>
                <Header as='h2'>
                    <Icon name='user' />
                    <Header.Content>Reactivities</Header.Content>
                </Header>
                <List>
                    {this.state.values.map((value: any) => (
                        <List.Item key={value.id}> {value.name} </List.Item>))}
                </List>
            </div>
        );
    }
}

export default App;
