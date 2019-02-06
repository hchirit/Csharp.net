package Elements;

import Primitives.Point3D;
import Primitives.Vector;
import Primitives.Ray;
import java.util.Map;

/**
 * Created by HC on 06/05/2017.
 */
public class Camera {
    //Eye point of the camera
    private Point3D _P0;
    private Vector _vUp;
    private Vector _vTo;
    // cross product  vUp , vTo
    private Vector _vRight;

    // ***************** Constructors ********************** //
    public Camera(){
        this._P0=new Point3D(0,0,1);
        this._vUp=new Vector(1,0.0,0.0);
        this._vTo=new Vector(0.0,0.0,-1.0);
        this._vRight=_vUp.crossProduct(_vTo);
    }
    public Camera (Camera camera){
        this._vRight=camera.get_vRight();
        this._P0=camera.getP0();
        this._vTo=camera.get_vTo();
        this._vUp=camera.get_vUp();
    }
    public Camera (Point3D P0, Vector vUp, Vector vTo){
        _P0 = new Point3D(P0);
        _vUp = new Vector(vUp);
        _vTo = new Vector(vTo);

        _vRight = _vUp.crossProduct(_vTo);
        _vUp = _vTo.crossProduct(_vRight);

        _vUp.normalize();
        _vTo.normalize();
        _vRight.normalize();
    }


    // ***************** Getters/Setters ********************** //
    public Vector get_vUp(){return new Vector(this._vUp);}
    public void set_vUp(Vector vUp){this._vUp=new Vector(vUp);}
    public Vector get_vTo(){return new Vector(this._vTo);}
    public void set_vTo(Vector vTo){this._vTo=new Vector(vTo);}
    public Point3D getP0(){return new Point3D(_P0);}
    public void setP0(Point3D P0){this._P0=new Point3D(P0);}
    public Vector get_vRight(){return new Vector(_vRight);}

    // ***************** Administration ********************** //
    public String toString(){
       return "Vto: " + _vTo + "\n" + "Vup: " + _vUp + "\n" + "Vright:" + _vRight +"P0: " + _P0 + "\n" + ".";
    }

    // ***************** Operations ******************** //
    /*
    * image center:
    * Pc=P0+dVto  P0=camera ;dVto=distance between camera and the plane pixel
    *
    * Vright=Vup X Vto
    *
    * Ratio(pixel width):
    * Rx=w/#pixels_x
    * Ry=h/#pixels_y
    *
    * P=Pc+[[(x-(#pixels_x/2))*Rx+Rx/2]Vright-[(y-(#pixels_y/2))*Ry+Ry/2]Vup]
    *
    * after that we creat a vector from the eye of the camera to the point P
    *
    * w=screenWidht
    * h=screenHeight
    * #pixels_x=Nx
    * #pixels_y=Ny
    * */
    public Ray constructRayThroughPixel (int Nx, int Ny, double x, double y,
                                         double screenDist, double screenWidth,
                                         double screenHeight){
        //image center
        Point3D Pc=new Point3D(_P0);
        Vector VtoWard=new Vector(_vTo);
        VtoWard.scale(screenDist);
        Pc.add(VtoWard);

        //Ratio (pixel widht)
        double Rx=screenWidth/Nx;
        double Ry=screenHeight/Ny;


        // P=Pc+(((x-Nx/2.0)*Rx+Rx/2.0)*get_vRight()-((y-Ny/2)Ry+Ry/2)*get_vUp());
        Vector Vright=new Vector(_vRight);
        Vector Vup=new Vector(_vUp);
        Vright.scale((x-Nx/2.0)*Rx+Rx/2.0);
        Vup.scale((y-Ny/2.0)*Ry+Ry/2.0);
        Vright.subtract(Vup);
        Pc.add(Vright);
        Point3D P=new Point3D(Pc);

        //vector between P0 and the intersection
        Vector V= new Vector(_P0,P);
        V.normalize();

        return new Ray(P,V);
    }
}