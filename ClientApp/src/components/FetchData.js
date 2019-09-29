import React, { useEffect, useState } from 'react'
import axios from 'axios'

// const response = await fetch('https://localhost:5001/api/Questions', {
//   method: 'post',
//   body: console.log('Posted')
// })

const Questions = props => {
  const [data, setData] = useState({ data: [] })
  const getData = async () => {
    const resp = await axios.post(`https://localhost:5001/api/Questions`)
    console.log('Posted')
    // const json = JSON.parse(resp.data.contents)
    // setInfo(json)
    // console.log(json)
  }
  useEffect(() => {
    getData()
  }, [])

  return (
    <div>
      <textarea></textarea>
      <input type="submit" onClick="getData" />
    </div>
  )
}

export default Questions
