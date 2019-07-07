<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="acercaDe.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.acercaDe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
        <!--================Banner Area =================-->
        <section class="banner_area">
            <div class="container">
                <div class="banner_inner_text">
                    <h2>Acerca de nosotros</h2>
                    <p>Cnocenos</p>
                </div>
            </div>
        </section>
        <!--================End Banner Area =================-->
        
        <!--================Challange Area =================-->
        <section class="challange_area p_100">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-6">
                        <div class="challange_text_inner">
                            <div class="l_title">
                                <img src="../recursos/img/icon/title-icon.png" alt="">
                                <h6>¿Quiènes somos?</h6>
                                <h2>Somos futuros programadores</h2>
                            </div>
                            <p>Somos Elias Moguel, Sarai Pech y Andrea Turriza, estudiantes del tercer cuatrimestre en la carrera de desarrollo de software multiplataforma en la Universidad Tecnològica Metropolitana (UTM). Como entregable del tercer cutrimiestre estamos desarrolando esta pàgina web dirigida hacìa escritores y lectores independientes. </p>
                            <div class="c_video">
                                <a class="popup-youtube" href="https://www.youtube.com/watch?v=62QYQE6k7tg"><img src="img/icon/video-icon.png" alt="">Mira como trabajamos</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 challange_img">
                        <div class="challange_img_inner">
                            <img class="img-fluid" src="../recursos/img/popup-photo.jpg" alt="">
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--================End Challange Area =================-->
        
        <!--================Testimonials Slider Area =================-->
        <section class="testimonials_area">
            <div class="container">
                <div class="testimonials_slider owl-carousel">
                    <div class="item">
                        <div class="testi_item">
                            <h3>“Muy Profesionales”</h3>
                            <p>Este equipo es uno de mis favoritos, siempre han sido muy responsables con las entregas cumpliendo con todos los puntos que se les pide, muy buen diseño y funcionalidad, sigan asì.</p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-1.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Marisa Concespciòn</h4>
                                    <h5>Maestra de Programaciòn en la UTM</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="testi_item">
                            <h3>“Son los mejores”</h3>
                            <p>Los mejores estudiantes que he tenido, desde que les impartì la clase de POO supe que llegarìan lejos, me siento muy orgulloso de ellos, estoy segurpo de que llegaràn lejos con esta grandiosa pàgina Web</p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-2.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Aurelio Mex</h4>
                                    <h5>Maestro de Programaciòn en la UTM</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="testi_item">
                            <h3>“Los adoro”</h3>
                            <p>Muy buena programaciòn, una pàgina web bastante completa y amigable hacìa el usuario, espero mucho de ellos tanto en este proyecto como para el proyecto integrador, tengo alstas expectativas, sigan asì.</p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-3.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Eduardo Moreno</h4>
                                    <h5>Coordinador de al area TIC en la UTM</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="testi_item">
                            <h3>“Muy buenos”</h3>
                            <p>Muy buena pàgina web, bastante funcional y completa, me impresiona que ha su corto periodo de estudios ya sean tan buenos programando, siendo ingeniosos para solucionar los problemas que se les presetan, espero bastante de ustedes. </p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-1.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Ing. Pablo Tostado</h4>
                                    <h5>Director de area TIC en la UTM</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--================End Testimonials Slider Area =================-->
        
        <!--================We Are Company Area =================-->
        <section class="we_company_area p_100">
            <div class="container">
                <div class="row company_inner">
                    <div class="col-lg-6">
                        <div class="left_company_text">
                            <div class="l_title">
                                <img src="img/icon/title-icon.png" alt="">
                                <h6>Nuestras estadìsticas</h6>
                                <h2>Somos<span>completamente</span>independientes</h2>
                            </div>
                            <p>Al ser una pàgina independiente, nos interesa saber que es lo que piensan nuestros usuarios sobre nuesta pàgina, aquì estan nuestras estadìsticas </p>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="company_skill">
							<br />
                            <p>Estadìsticas en tiempo real</p>
                            <div class="our_skill_inner">
                                <div class="single_skill">
                                    <h3>Desarrollo</h3>
                                    <div class="progress" data-value="100">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">100</span>%</div>
                                        </div>
                                    </div>
                                </div>
                                <div class="single_skill">
                                    <h3>Diseño</h3>
                                    <div class="progress" data-value="90">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">90</span>%</div>
                                        </div>
                                    </div>
                                </div>
                                <div class="single_skill">
                                    <h3>Amigable al usuario</h3>
                                    <div class="progress" data-value="85">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">85</span>%</div>
                                        </div>
                                    </div>
                                </div>
                                <div class="single_skill">
                                    <h3>Usabilidad</h3>
                                    <div class="progress" data-value="90">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">90</span>%</div>
                                        </div>
                                    </div>
                                </div>
                                <div class="single_skill">
                                    <h3>Innovador</h3>
                                    <div class="progress" data-value="85">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">85</span>%</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--================End We Are Company Area =================-->
        
        <!--================End We Are Company Area =================-->
        <section class="talk_area">
            <div class="container">
                <div class="talk_text">
                    <h4>¿Estas listo para hablar? Contactanos</h4>
                    <a href="mailto:contact@sierracompany.com">SaritaPech15@gmail.com</a>
                </div>
            </div>
        </section>
        <!--================End We Are Company Area =================-->
        
        <!--================Footer Area =================-->
        <footer class="footr_area">
            <div class="footer_widget_area">
                <div class="container">
                    <div class="row footer_widget_inner">
                        <div class="col-lg-4 col-sm-6">
                            <aside class="f_widget f_about_widget">
                                <img src="img/footer-logo.png" alt="">
                                <p>Contactanos en redes sociales</p>
                            </aside>
                        </div>
                        <div class="col-lg-4 col-sm-6">
                            <aside class="f_widget f_insta_widget">
                                <div class="f_title">
                                    <h3>Instagram</h3>
                                </div>
                                <ul>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-1.jpg" alt=""></a></li>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-2.jpg" alt=""></a></li>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-3.jpg" alt=""></a></li>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-4.jpg" alt=""></a></li>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-5.jpg" alt=""></a></li>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-6.jpg" alt=""></a></li>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-7.jpg" alt=""></a></li>
                                    <li><a href="#"><img src="../recursos/img/instagram/ins-8.jpg" alt=""></a></li>
                                </ul>
                            </aside>
                        </div>
                        <div class="col-lg-4 col-sm-6">
                            <aside class="f_widget f_subs_widget">
                                <div class="f_title">
                                    <h3>Suscribete</h3>
                                </div>
                                <div class="input-group">
                                    <input type="text" class="form-control" placeholder="Tu email aquì" aria-label="Tu email aquì">
                                    <span class="input-group-btn">
                                        <button class="btn btn-secondary submit_btn" type="button">Suscribete</button>
                                    </span>
                                </div>
                            </aside>
                        </div>
                    </div>
                </div>
            </div>




</asp:Content>
