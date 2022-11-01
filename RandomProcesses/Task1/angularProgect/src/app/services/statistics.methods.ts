
export interface IPoint {
    x: number;
    y: number;
}

export class Statistics {

    public static mean(data: IPoint[]) {
        let sum = 0;
        data.forEach(el => sum += el.y);
        return sum / data.length;
    }
}