let data: number | string;
data = "43";
export interface ICar{
    color: string;
    model: string;
    topSpeed?: number;
}

const car1: ICar = {
    color: 'blue',
    model: 'bmw'
}
const car2: ICar = {
    color: 'red',
    model: 'merceders',
    topSpeed: 100
}
const multiply = (x: number, y: number) => (x * y)

export const cars = [ car1, car2 ];
