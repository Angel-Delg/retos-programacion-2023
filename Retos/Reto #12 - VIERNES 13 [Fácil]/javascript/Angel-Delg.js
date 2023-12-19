const thisMonthContains13thFriday = ( month, year ) => {
   const currentDate = new Date(year, month - 1, 13).getDay()
   return (currentDate === 5)
}

console.log(thisMonthContains13thFriday(3, 2023))