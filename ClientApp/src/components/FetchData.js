import React, { useEffect, useState } from 'react'
import axios from 'axios'

// const response = await fetch('https://localhost:5001/api/Questions', {
//   method: 'post',
//   body: console.log('Posted')
// })

const Questions = props => {
  const [data, setData] = useState({ data: [] })
  const getData = async () => {
    const resp = await axios.get(`https://localhost:5001/api/Questions`)
      .then(resp => {
        console.log(resp.data)
      })
    console.log('Posted')
    // const json = JSON.parse(resp.data.contents)
    // setInfo(json)
    // console.log(json)
  }

  const [newQuestion, setnewQuestion] = useState({})
  const postData = async () => {
    const resp = await axios.post(`https://localhost:5001/api/Questions`, {
      id: 1,
      Title: "Title"
    })

      .then(resp => {
        console.log(resp.data)
      })
  }


  useEffect(() => {
    getData()
  }, [])

  return (
    <div>
      <textarea></textarea>
      <input type="submit" onClick={postData} />
      <button onClick={getData}>New Qusetion</button>
    </div>
  )
}

export default Questions
