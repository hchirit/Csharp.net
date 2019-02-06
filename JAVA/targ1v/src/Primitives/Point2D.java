package Primitives;

/**
 * Created by HC on 20/03/2017.
 */
public class Point2D {
    //attributes
    protected Coordinate _x;
    protected Coordinate _y;

    // ***************** Constructors ********************** //
    public Point2D() {
        this._x=new Coordinate();
        this._y=new Coordinate();
    }
    public Point2D(Coordinate x, Coordinate y) {
        this._x=new Coordinate(x);
        this._y=new Coordinate(y);
       }
       public Point2D(Point2D point2D){
          this._x = point2D.getX();
          this._y = point2D.getY();
       }


    // ***************** Getters/Setters ********************** //
    public Coordinate getX() {
        return new Coordinate(this._x);
    }
    public Coordinate getY() {
        return new Coordinate(this._y);
    }
    public void setX(Coordinate _x){this._x=new Coordinate(_x);}
    public void setY(Coordinate _y){this._y=new Coordinate(_y);}


    @Override
    //Point2D(x,y)
    public String toString() {
        return "Point2D(" +
                 getX()+
                ","+
                getY() +
                ')';
    }
    // ***************** Administration ******************** //
    public int compareTo(Point2D point2D){
        if (point2D.getX()==this.getX()&& point2D.getY()==this.getY())
            return 0;
        else
            return -1;
    }

}
