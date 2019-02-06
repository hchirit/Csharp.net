package Primitives;

import java.text.DecimalFormat;
import java.text.NumberFormat;

/**
 * Created by HC on 20/03/2017.
 */
public class Point3D extends Point2D  {
    //attributes
    private Coordinate _z;

    // ***************** Constructors ********************** //
    public Point3D() {
        _z = new Coordinate();
    }
    public Point3D(Coordinate x, Coordinate y, Coordinate z) {
        super(x, y);
        this._z =new Coordinate(z);
    }
    public Point3D(double x, double y, double z){
        super(new Coordinate(x),new Coordinate(y));
        this._z=new Coordinate(z);
    }
    public Point3D(Point3D point3D){
        super(new Point2D(new Coordinate(point3D.getX()),new Coordinate(point3D.getY())));
        this._z = new Coordinate(point3D.getZ());
    }

    // ***************** Getters/Setters ********************** //
    public Coordinate getZ() {
        return new Coordinate(_z);
    }
    public void setZ(Coordinate _z) {
        this._z = new Coordinate(_z);
    }


    // ***************** Administration ******************** //
    @Override
    public String toString(){
       // String point = "(" + String.format("%.2f", this._x.getCoordinate()) + "," + String.format(" %.2f",this._y.getCoordinate()) + "," + String.format(" %.2f",this._z.getCoordinate()) + ")";
      //  return point;
        return String.format("(%.2f, %.2f, %.2f)",this._x.getCoordinate(),this._y.getCoordinate(), this._z.getCoordinate());
    }

    public int compareTo(Point3D point3D){
        if (this._x.compareTo(point3D.getX()) == 0 && this._y.compareTo(point3D.getY()) == 0 && this._z.compareTo(point3D.getZ()) == 0)
            return 0;
        else
            return -1;
    }

    // ***************** Operations ******************** //
    public void add(Vector v){
        this._x.add(v.getHead().getX());
        this._y.add(v.getHead().getY());
        this._z.add(v.getHead().getZ());

    }
    public void substract(Vector v){
        this._x.substract(v.getHead().getX());
        this._y.substract(v.getHead().getY());
        this._z.substract(v.getHead().getZ());
    }
    public double distance(Point3D point){
        return Math.sqrt( Math.pow((point.getX().getCoordinate()-this.getX().getCoordinate()),2) + Math.pow((point.getY().getCoordinate()-this.getY().getCoordinate()),2) + Math.pow((point.getZ().getCoordinate()-this.getZ().getCoordinate()),2));
    }





}
