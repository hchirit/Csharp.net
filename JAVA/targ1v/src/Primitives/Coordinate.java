package Primitives;

/**
 * Created by HC on 20/03/2017.
 */
public class Coordinate {
    //attributes
    private double _coordinate;

    // ***************** Constructors ********************** //
    public Coordinate()                      { this._coordinate = 0.0;                    }
    public Coordinate(double coordinate)     { this._coordinate = coordinate;             }
    public Coordinate(Coordinate coordinate) { this._coordinate = coordinate._coordinate; }

    // ***************** Getters/Setters ********************** //
    public double getCoordinate() {
        return _coordinate;
    }
    public void setCoordinate(double coordinate) {
        this._coordinate = coordinate;
    }




    // ***************** Administration ******************** //
    public int compareTo(Coordinate coordinate){
        if(this._coordinate==coordinate._coordinate)
            return 0;
        else
            return -1;
    }

    // ***************** Operations ******************** //
    public void add(Coordinate coordinate){
        this._coordinate+=coordinate.getCoordinate();
    }
    public void substract(Coordinate coordinate){
        this._coordinate-=coordinate.getCoordinate();
    }
}
