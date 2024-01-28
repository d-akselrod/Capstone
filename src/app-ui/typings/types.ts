export interface IProfile {
  uId: string;
  firstName?: string;
  lastName?: string;
  username: string;
}

export interface IUser extends IProfile {
  email: string;
  password: string;
}

export interface IWorkoutCategory {
  image: any;
  imgWidth: number;
  imgHeight: number;
  categoryName: string;
  numOfExercises: number;
}

export interface IWorkout {
  date: Date;
  duration: number;
  numOfExercises: number;
  wId: string;
  name: string;
}
