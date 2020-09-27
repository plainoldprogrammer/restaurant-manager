import React, { Component } from 'react';

export class Employees extends Component {
  static displayName = Employees.name;

  constructor(props) {
    super(props);
    this.state = { employees: [], loading: true };
  }

  componentDidMount() {
    this.populateEmployeesData();
  }

  static renderEmployeesTable(employees) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>First Name</th>
            <th>Last Name</th>
          </tr>
        </thead>
        <tbody>
          {employees.map(employee =>
            <tr key={employee.date}>
              <td>{employee.id}</td>
              <td>{employee.firstName}</td>
              <td>{employee.lastName}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Employees.renderEmployeesTable(this.state.employees);

    return (
      <div>
        <h1 id="tabelLabel">Employees</h1>
        <p>Employees panel</p>
        {contents}
      </div>
    );
  }

  async populateEmployeesData() {
    const response = await fetch('https://localhost:5001/employees/all');
    const data = await response.json();
    this.setState({ employees: data, loading: false });
  }
}
