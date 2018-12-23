export class Person {
  firstName: string
  lastName: string
  age: number
  email: string
  streetAddress: string
  city: string
  state: string
  zip: string
  photo: string
  interests: Interest[]
}

export class Interest {
  name: string
}
