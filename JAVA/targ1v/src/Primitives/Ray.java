package Primitives;

/**
 * Created by HC on 30/04/2017.
 */
public class Ray {
    // ***************** Attribute ********************** //
    //point of origin
    Point3D _POO;
    //ray direction
    Vector _direction;

    // ***************** Constructors ********************** //
    public Ray(){
        this._POO=new Point3D();
        this._direction=new Vector();
    }
    public Ray(Ray ray){
        this._POO=ray.getPOO();
        this._direction=ray.getDirection();
    }
    public Ray(Point3D poo, Vector direction){
        this._POO=new Point3D(poo);
        this._direction=new Vector(direction);
        this._direction.normalize();
    }
    // ***************** Getters/Setters ********************** //
    public void setPOO(Point3D _POO){
        this._POO=new Point3D(_POO);
    }
    public void setDirection(Vector _direction){
        this._direction=new Vector(_direction);
    }
    public Vector getDirection(){return new Vector(this._direction);}
    public Point3D getPOO(){return new Point3D(this._POO);}
}
