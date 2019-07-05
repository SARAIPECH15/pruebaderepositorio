<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="acercaDe.aspx.cs" Inherits="ProyectoWebPageMaster.GUI.acercaDe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
        <!--================Banner Area =================-->
        <section class="banner_area">
            <div class="container">
                <div class="banner_inner_text">
                    <h2>Acerca de nosotros</h2>
                    <p>Conocenos</p>
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
                                <h6>¿Qué es lo qu hacemos?</h6>
                                <h2>No nos escondemos, somos los mejores en lo que hacemos</h2>
                            </div>
                            <p>Somos: Elias Moguel, Sarai Pech y Andrea Turriza, 3 estudiantes que cursan la carrera de Desarrollo de Software Multiplataforma en la UTM (Universidad Tecnológica Metropolitana), este tercer cuatrimestre tenemos como entregable una página web para escritores y lectores, esperamos que sea de su agrado.   </p>
                            <div class="c_video">
                                <a class="popup-youtube" href="https://www.youtube.com/watch?v=62QYQE6k7tg"><img src="img/icon/video-icon.png" alt="">Mira como tabajamos </a>
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
                            <h3>“Un muy buen comienzo”</h3>
                            <p>Teniendo encuenta lo jovenes que son y el hecho de que aun están el tercer cuantrimestre, esta página esta bastante completa</p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-1.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Marisa Concepción</h4>
                                    <h5>Maestra de Programación Web en la UTM</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="testi_item">
                            <h3>“SON LOS MEJORES”</h3>
                            <p>Desde que les di clase el segundo cuatrimestre supe que llegarían lejos y no me han defraudado, muy buena página Web, sigan así.</p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-2.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Aurelio Mex</h4>
                                    <h5>Maestro de Programación Web en la UTM</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="testi_item">
                            <h3>“Los Amo”</h3>
                            <p>Son los mejores de todo el 3C, son muy responasables y dedicados, espero mucho de ellos</p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-3.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Eduardo Moreno</h4>
                                    <h5>Coordinador de la división TIC en la UTM</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="testi_item">
                            <h3>“Nada como ellos”</h3>
                            <p>Me sorprende lo buenos que son los jovenes desarrolladores de esta epoca, una página web muy completa y eficiente, sigan así.</p>
                            <div class="media">
                                <div class="d-flex">
                                    <img class="rounded-circle" src="../recursos/img/testimonials/testi-1.jpg" alt="">
                                </div>
                                <div class="media-body">
                                    <h4>Ing. Pablo Tostado</h4>
                                    <h5>Director del area TIC en la UTM</h5>
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
                                <h6>Nuestras Estadisticas</h6>
                                <h2>Somos <span>un</span>proyecto independiente</h2>
                            </div>
                            <p>Como somos un proyecto independiente, nos gusta saber que piensan nuestros usuarios sobre esta página Web y que mejor forma de verlo que representarlo en una gráfica. Estas son nuestras estadísticas en tiempo real </p>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="company_skill">
                            <p>Aquí podras encontrar lo que se dice de nostros</p>
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
                                    <h3>Facíl de usar</h3>
                                    <div class="progress" data-value="85">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">85</span>%</div>
                                        </div>
                                    </div>
                                </div>
                                <div class="single_skill">
                                    <h3>Amigable</h3>
                                    <div class="progress" data-value="90">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">90</span>%</div>
                                        </div>
                                    </div>
                                </div>
                                <div class="single_skill">
                                    <h3>Buen contenido</h3>
                                    <div class="progress" data-value="95">
                                        <div class="progress-bar">
                                            <div class="progress_parcent"><span class="counter">95</span>%</div>
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
                    <h4>¿Estas listo para hablar?</h4>
                    <a href="mailto:contact@sierracompany.com">saritapech15@gmail.com</a>
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
                                <p>Visitanos de nuestras redes sociales</p>
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
                                    <h3>Suscribite</h3>
                                </div>
                                <div class="input-group">
                                    <input type="text" class="form-control" placeholder="Tu correo electronico" aria-label="Tu correo electronico aquí">
                                    <span class="input-group-btn">
                                        <button class="btn btn-secondary submit_btn" type="button">Suscribite</button>
                                    </span>
                                </div>
                            </aside>
                        </div>
                    </div>
                </div>
            </div>




</asp:Content>
