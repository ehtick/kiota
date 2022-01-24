import { AuthenticationProvider } from "./authenticationProvider";

/** This authentication provider does not perform any authentication.   */
export class AnonymousAuthenticationProvider implements AuthenticationProvider {
    public authenticateRequest = () : Promise<void> => {
        return Promise.resolve();
    };
}