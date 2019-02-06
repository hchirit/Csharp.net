package Primitives;

/**
 * Created by HC on 20/03/2017.
 */
public class Vector {
    //two Point3D with one (0,0,0)

    // ***************** Attribute ********************** //
    private Point3D _head;

    // ***************** Constructors ********************** //
    public Vector() {
       this._head=new Point3D();
    }
    public Vector(Point3D head) {
        this._head=new Point3D(head);
    }
    public Vector(Vector vector){
        this._head=vector.getHead();
    }
    public Vector(double xHead, double yHead, double zHead){
        this._head=new Point3D(new Coordinate(xHead),
                new Coordinate(yHead),
                new Coordinate(zHead));

    }
    public Vector(Point3D p1, Point3D p2){

        this(p2.getX().getCoordinate() - p1.getX().getCoordinate(),
                p2.getY().getCoordinate() - p1.getY().getCoordinate(),
                p2.getZ().getCoordinate() - p1.getZ().getCoordinate());
    }

    // ***************** Getters/Setters ********************** //
    public Point3D getHead() {
        return new Point3D(_head);
    }
    public void setHead(Point3D head) {
        this._head = new Point3D(head);
    }

    // ***************** Administration ******************** //
    public int compareTo(Vector vector){
        if (this._head.compareTo(vector.getHead())==0)
            return 0;
        else
            return -1;


    }

    @Override
    public String toString() {
        return _head.toString();
    }

    // ***************** Operations ******************** //
    //sum of two vector donne un nouveau vecteur (ex:u+v=>la queu de u qui joins la tete de v)
    public void add (Vector vector ){
        this._head.add(vector);
    }

    //subtract of two vector
    public void subtract (Vector vector){
        this._head.substract(vector);
    }

    //scale:(x,y,z)*a=(xa,ya,za)  agrandi la taille du vecteur
    public void scale(double scalingFactor){
        this._head.setX(new Coordinate(_head.getX().getCoordinate()*scalingFactor));
        this._head.setY(new Coordinate(_head.getY().getCoordinate()*scalingFactor));
        this._head.setZ(new Coordinate(_head.getZ().getCoordinate()*scalingFactor));
    }

    //cross:(u2v3-u3v2,u3v1-u1v3,u1v2-u2v1)
    public Vector crossProduct(Vector vector){
        double u1=this.getHead().getX().getCoordinate();
        double u2=this.getHead().getY().getCoordinate();
        double u3=this.getHead().getZ().getCoordinate();

        double v1=vector.getHead().getX().getCoordinate();
        double v2=vector.getHead().getY().getCoordinate();
        double v3=vector.getHead().getZ().getCoordinate();

        return new Vector(u2*v3-u3*v2,u3*v1-u1*v3,u1*v2-u2*v1);
    }

    //size of vector
    public double length(){
        double x1=this._head.getX().getCoordinate();
        double x2=this._head.getY().getCoordinate();
        double x3=this._head.getZ().getCoordinate();

        //sqrt(x1^2+x^2+x3^2)
        return Math.sqrt(Math.pow(x1,2)+Math.pow(x2,2)+Math.pow(x3,2));
    }

    public void normalize(){
        double x1=this._head.getX().getCoordinate();
        double x2=this._head.getY().getCoordinate();
        double x3=this._head.getZ().getCoordinate();

      try {
          if (this.length() == 0)// Throws exception if length = 0
              throw new ArithmeticException();
          this.setHead(new Point3D(x1 / this.length(), x2 / this.length(), x3 / this.length()));
      }
      catch(ArithmeticException e){}
    } 

    //dot:(a,b,c)*(x,y,z)=ax+by+cz
    public double dotProduct(Vector vector){

        return this._head.getX().getCoordinate()*vector._head.getX().getCoordinate()+
                this._head.getY().getCoordinate()*vector._head.getY().getCoordinate()+
                this._head.getZ().getCoordinate()*vector._head.getZ().getCoordinate();
    }
}
