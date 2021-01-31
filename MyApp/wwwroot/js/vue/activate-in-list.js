Vue.component(`table-person`, {
    props:[`list`],
    template: `<table class="table">
    <thead>
      <tr>
        <th scope="col">id</th>
        <th scope="col">name</th>
        <th scope="col">price</th>
        <th scope="col">#</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>Mark</td>
        <td>Otto</td>
        <td>Otto</td>
        <td><button class="btn btn-primary btn-sm">click</button></td>
      </tr>
    </tbody>
  </table>`
})
